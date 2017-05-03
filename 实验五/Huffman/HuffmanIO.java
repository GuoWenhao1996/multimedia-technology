package com.gwh.Huffman;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class HuffmanIO {
	public static void writeFile(String file) {
		try {
			FileWriter fileWriter = new FileWriter(file);
			String s = new String("This is a test!  \n" + "aaaa");
			fileWriter.write(s);
			fileWriter.close(); // 关闭数据流
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void readFile(String file) {
		try{
			FileReader fileReader = new FileReader(file);
			String s = null;
			char ch;
			try {
				char[] c = new char[100];
				fileReader.read(c, 0, 2); // 具体想得到文件里面的什么值（单个char？int？还是String?），
				System.out.println(c);
				fileReader.close();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}
