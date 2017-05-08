package com.gwh.Huffman;

import java.util.*;

public class HuffmanCode {
	static String[] testFreqs = new String[256];

	// input is an array of frequencies, indexed by character code
	public static HuffmanTree buildTree(int[] charFreqs) {
		PriorityQueue<HuffmanTree> trees = new PriorityQueue<HuffmanTree>();
		// initially, we have a forest of leaves
		// one for each non-empty character
		for (int i = 0; i < charFreqs.length; i++)
			if (charFreqs[i] > 0)
				trees.offer(new HuffmanLeaf(charFreqs[i], (char) i));

		assert trees.size() > 0;
		// loop until there is only one tree left
		while (trees.size() > 1) {
			// two trees with least frequency
			HuffmanTree a = trees.poll();
			HuffmanTree b = trees.poll();

			// put into new node and re-insert into queue
			trees.offer(new HuffmanNode(a, b));
		}
		return trees.poll();
	}

	public static void printCodes(HuffmanTree tree, StringBuffer prefix) {
		assert tree != null;
		if (tree instanceof HuffmanLeaf) {
			HuffmanLeaf leaf = (HuffmanLeaf) tree;

			// print out character, frequency, and code for this leaf (which is
			// just the prefix)
			System.out.println(leaf.value + "\t" + leaf.frequency + "\t" + prefix);
			testFreqs[leaf.value] = prefix.toString();
		} else if (tree instanceof HuffmanNode) {
			HuffmanNode node = (HuffmanNode) tree;

			// traverse left
			prefix.append('0');
			printCodes(node.left, prefix);
			prefix.deleteCharAt(prefix.length() - 1);

			// traverse right
			prefix.append('1');
			printCodes(node.right, prefix);
			prefix.deleteCharAt(prefix.length() - 1);
		}
	}

	public static void main(String[] args) {

		String file = "lzw.c";
		String path = "E:\\郭大神的作业\\多媒体技术\\第5节课-压缩算法\\task1-Huffman\\";
		String text = HuffmanIO.readFile(path + file);

		// we will assume that all our characters will have
		// code less than 256, for simplicity
		int[] charFreqs = new int[256];
		try {
			// read each character and record the frequencies
			for (char c : text.toCharArray())
				charFreqs[c]++;

			// build tree
			HuffmanTree tree = buildTree(charFreqs);

			// print out results
			System.out.println("SYMBOL\tWEIGHT\tHUFFMAN CODE");
			printCodes(tree, new StringBuffer());
			System.out.println("源文件：");
			System.out.println(text);
			String huffmanText = "";
			huffmanText = setHuffmanText(huffmanText, text);
			System.out.println("压缩后文件：");
			System.out.println(huffmanText);
			// HuffmanIO.writeFile(huffmanText, path + "Huffman_" +
			// file.substring(0, file.length() - 4) + ".dat");
			// System.out.println("压缩成功！文本文件压缩至->" + "Huffman_" +
			// file.substring(0, file.length() - 4) + ".dat");
			HuffmanIO.writeFileByBinary(huffmanText, path + "HuffBin_" + file.substring(0, file.length() - 4) + ".dat");
			System.out.println("压缩成功！二进制文件压缩至->" + "HuffBin_" + file.substring(0, file.length() - 4) + ".dat");

		} catch (Exception e) {
			System.err.println("文本中有非法字符！");
			System.err.println("源文件：");
			System.err.println(text);
		}
	}

	private static String setHuffmanText(String huffmanText, String test) {
		for (int i = 0; i < test.length(); i++) {
			huffmanText += testFreqs[test.charAt(i)];
		}
		return huffmanText;
	}
}