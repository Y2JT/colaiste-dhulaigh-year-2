/**
 * @(#)shapesMethod.java
 * Have a menu which will ask the user what shape they want printed
 * The menu should keep looping until they choose to exit
 * The menu is
 * 1: Square
 * 2: Rectangle
 * 3: Triangle
 * 4: Quit
 * Each menu option will take inputs (length for square and triangle and width for rectangle)
 * from the user and pass the inputs to the method
 * Exit will also have a method
 *
 * @author
 * @version 1.00 2015/10/16
 */

import java.util.Scanner;
public class shapesMethod {

	static Scanner input = new Scanner(System.in);
	static int width = 0;

    public static void main(String args[]) {
    	int length =0;
    	int choice =0;

    	//show menu
    	while(choice!=4){
    		System.out.print("----- MENU -----\n");
    		System.out.println("1: Square \n2: Rectangle \n3: Triangle \n4: Quit");
    		System.out.print("\nPlease select an option: ");
    		choice = input.nextInt();

    		//choice 1 (square)
    		if(choice ==1){
    			System.out.print("\nEnter length of Square: ");
    			length = input.nextInt();
    			System.out.println();
    			//method call
    			square(length);
    		}//end choice 1 (square)

    		//choice 2 (rectangle)
    		else if(choice ==2){
    			System.out.print("\nEnter length of Rectangle: ");
    			length = input.nextInt();
    			System.out.print("Enter width of Rectangle: ");
    			width = input.nextInt();
    			System.out.println();
    			//method call
    			rectangle(length);
    		}//end choice 2 (rectangle)

    		//choice 3 (triangle)
    		else if(choice ==3){
    			System.out.print("\nEnter length of Triangle: ");
    			length = input.nextInt();
    			System.out.println();
    			//method call
    			triangle(length);
    		}//end choice 3 (triangle)

    	}//end while

    	//method call
    	quit();

    }//end main method

    public static void square(int lengtha){
    	for(int i =1; i<=lengtha;i++){
    		for(int x=1;x<=lengtha;x++){
    			System.out.print("*");
    		}//end inner for
    		System.out.println();
    	}//end outer for
    	System.out.println();
    }//end square method

    public static void rectangle(int lengthb){
    	for(int i=1; i<=lengthb;i++){
    		for(int x=1; x<=width;x++){
    			System.out.print("*");
    		}//end inner for
    		System.out.println();
    	}//end outer for
    	System.out.println();
    }//end rectangle method

    public static void triangle(int lengthc){
    	for(int i=1; i<lengthc;i++){
    		for(int x=1;x<=i;x++){
    			System.out.print("*");
    		}//end inner for
    		System.out.println();
    	}//end outer for
    	System.out.println();
    }//end triangle method

    public static void quit(){
    System.out.println("\n\nThank you and goodbye\n\n");
    System.exit(0);
    }//end quit method

}//end class