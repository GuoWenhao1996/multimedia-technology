% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�01.wav');%700Hz 1210Hz ���Ϊ��1��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�02.wav');%855Hz 1335Hz ���Ϊ��8��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�03.wav');%850Hz 1480Hz ���Ϊ��9��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�04.wav');%850Hz 1340Hz ���Ϊ��8��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�05.wav');%700Hz 1480Hz ���Ϊ��3��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�06.wav');%850Hz 1480Hz ���Ϊ��9��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�07.wav');%700Hz 1340Hz ���Ϊ��2��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�08.wav');%700Hz 1210Hz ���Ϊ��1��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�09.wav');%770Hz 1340Hz ���Ϊ��5��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�10.wav');%700Hz 1480Hz ���Ϊ��3��
% [xx,fs]=audioread('�ֻ�������0���з��ļ�/�ֻ��з�11.wav');%700Hz 1340Hz ���Ϊ��2��
x=xx(:,1);
N=length(x);
time=(0:N-1)/fs;
plot(x);

M=256;
nfft=8192;
win=hanning(M);
freq=(0:nfft/2)*fs/nfft;
y=x(91:90+M);
y=y-mean(y);
Y=fft(y.*win,nfft);
figure(2)
subplot 211; plot(y); xlim([0 M]);
title('һ֡�źŲ���'); xlabel('����'); ylabel('��ֵ')
subplot 212; plot(freq,20*log10(abs(Y(1:nfft/2+1))));
grid; axis([0 max(freq) -60 55]);
title('Ƶ��'); xlabel('Ƶ��(Hz)'); ylabel('��ֵ')
