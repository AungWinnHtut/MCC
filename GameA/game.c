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
		system("cls");
		printf("user at %d,%d\n",ux,uy);
		printf("door at %d,%d\n",dx,dy);
		ch = _getch();
		
		/*if arrows*/
		if(ch==-32)
		{
			ch = _getch();
			/*left*/
   			if(ch==75)
   			{
   				ux--;
   				if(ux<0) ux=640;   			
   			}
   			/*right*/
   			if(ch==77)
   			{
   				ux++;
   				if(ux>640) ux=0; 			
   			}
   			/*up*/
   			if(ch==72)
   			{
   				uy--;
   				if(uy<0) uy=480;   						
   			}
   			/*down*/
   			if(ch==80)
   			{
   				uy++;
   				if(uy>480) uy=0;  			
   			}
		}


		if((ux==dx) && (uy==dy))
		{
			printf("you won the level");
			return 0;
		}



	}while(ch!=27);
	


	return 0;
}