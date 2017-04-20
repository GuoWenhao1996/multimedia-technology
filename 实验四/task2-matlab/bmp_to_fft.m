% i=imread('原图1.bmp');          			%读入原图像文件
% i=imread('原图2.bmp');          			%读入原图像文件
% i=imread('原图3.bmp');          			%读入原图像文件
i=imread('原图4.bmp');          			%读入原图像文件
figure(1);					%设定窗口
imshow(i);						%显示原图像
colorbar;						%显示图像的颜色条
title('原图像')						%图像命名
j=fft2(i);						%二维离散傅立叶变换
k=fftshift(j);						%直流分量移到频谱中心
figure(2);	%设定窗口
imshow(k,[]);	%显示原图像
colorbar;	%显示图像的颜色条
title('经过二维快速傅立叶变换后的图像')		%图像命名
n=ifft2(j)/255;                           	%逆二维快速傅里叶变换
figure(3);		%设定窗口
imshow(n,[]);                               		%显示原图像
colorbar;		%显示图像的颜色条
title('经过二维快速傅立叶逆变换后的图像')		%图像命名
