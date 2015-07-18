#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main()
{

	int ux=0,uy=0,dx=0,dy=0;

	int i;
	time_t t;
	srand((unsigned) time(&t));
	i=rand()%6;
	printf("i=%d",i+1);
	return 0;
}