[xx,fs]=audioread('����1-DTMF.wav');
% [xx,fs]=audioread('����2-440Hz.wav');
% [xx,fs]=audioread('����3-����.wav');
x=xx(:,1);
N=length(x);
time=(0:N-1)/fs;
plot(x);

M=2048;
nfft=8192;
win=hanning(M);
freq=(0:nfft/2)*fs/nfft;
y=x(9001:9000+M);
y=y-mean(y);
Y=fft(y.*win,nfft);
figure(2)
subplot 211; plot(y); xlim([0 M]);
title('һ֡�źŲ���'); xlabel('����'); ylabel('��ֵ')
subplot 212; plot(freq,20*log10(abs(Y(1:nfft/2+1)))); 
grid; axis([0 max(freq) -60 55]);
title('Ƶ��'); xlabel('Ƶ��(Hz)'); ylabel('��ֵ')
