#include<stdio.h>
#include<stdlib.h>
#include<time.h>


int main()
{

	int ux=0,uy=0,dx=0,dy=0;
	int status=0;
	char ch;

	int i;
	time_t t;
	srand((unsigned) time(&t));
	dx=rand()%641;
	dy=rand()%481;

	do{
		ux=rand()%641;
		uy=rand()%481;
	}while((ux==dx) && (uy==dy));
	
	
	do{

		printf("user at %d,%d\n",ux,uy);
		printf("door at %d,%d\n",dx,dy);
		ch = _getch();
		printf("****\n");
		printf("%d\n\n",ch);
		printf("****\n");

	}while(ch!=27);
	


	return 0;
}