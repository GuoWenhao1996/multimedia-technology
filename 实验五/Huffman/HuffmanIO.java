package com.gwh.Huffman;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.OutputStream;

public class HuffmanIO {

	public static boolean writeFileByBinary(String fileContent, String filePath) {
		boolean flag = false;
		OutputStream out = null;
		try {
			File file = new File(filePath);
			if (!file.exists()) {
				flag = file.createNewFile();
			}
			out = new FileOutputStream(filePath);
			char[] buf = fileContent.toCharArray();
			String temp = "";
			for (int i = 0; i < buf.length / 8; i++) {
				temp = "";
				for (int j = 0; j < 8; j++) {
					temp += buf[i * 8 + j];
				}
				int huff = Integer.valueOf(temp, 2);
				out.write(huff);
			}
			for (int i = buf.length / 8 *8; i < buf.length; i++) {
					temp += buf[i];
			}
			int huff = Integer.valueOf(temp, 2);
			out.write(huff);
			out.flush();
			out.close();
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			try {
				out.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
		return flag;
	}

	public static void writeFile(String str, String file) {
		try {
			FileWriter fileWriter = new FileWriter(file);
			fileWriter.write(str);
			fileWriter.close(); // 关闭数据流
		} catch (IOException e) {
			System.err.println("写入出错！");
			e.printStackTrace();
		}
	}

	public static String readFile(String file) {
		try {
			String text = "";
			FileReader fileReader = new FileReader(file);
			int ch;
			try {
				while ((ch = fileReader.read()) != -1) {
					text += (char) ch;
				}
				fileReader.close();
			} catch (Exception e) {
				System.err.println("文件读取出错！");
			}
			return text;
		} catch (FileNotFoundException e) {
			System.err.println("路径有误！");
			return null;
		}
	}
}
