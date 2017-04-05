% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分01.wav');%700Hz 1210Hz 查表为【1】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分02.wav');%855Hz 1335Hz 查表为【8】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分03.wav');%850Hz 1480Hz 查表为【9】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分04.wav');%850Hz 1340Hz 查表为【8】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分05.wav');%700Hz 1480Hz 查表为【3】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分06.wav');%850Hz 1480Hz 查表为【9】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分07.wav');%700Hz 1340Hz 查表为【2】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分08.wav');%700Hz 1210Hz 查表为【1】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分09.wav');%770Hz 1340Hz 查表为【5】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分10.wav');%700Hz 1480Hz 查表为【3】
% [xx,fs]=audioread('手机拨号音0的切分文件/手机切分11.wav');%700Hz 1340Hz 查表为【2】
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
title('一帧信号波形'); xlabel('样点'); ylabel('幅值')
subplot 212; plot(freq,20*log10(abs(Y(1:nfft/2+1))));
grid; axis([0 max(freq) -60 55]);
title('频谱'); xlabel('频率(Hz)'); ylabel('幅值')
