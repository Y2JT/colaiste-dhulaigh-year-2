/**
 * @(#)Assignment1.java
 * Joseph Tierney
 * @version 1.00 2015/11/11
 */

import java.util.Date;
import java.util.Scanner;
public class Assignment1 {

	static Scanner input = new Scanner(System.in);
	static String names[] = {"Joey","Tom","Phil","Rick","Daryl"};
	static int pins[] = {123,234,345,456,567};
	static int balance[]= {800,200,150,400,500};
	static int overdraft[] = {1,1,0,0,1};
	static int sub = 0;
	static boolean found = false;

    public static void main(String args[]) {

    	Date d = new Date();
    	System.out.print(d);

    	//method call login menu
    	loginmenu();

    }//end main method

    /****** LOGIN MENU METHOD *****/
    public static void loginmenu(){
    	String strchoice, strpin;
    	int choice, pin;

    	//display login menu
    	System.out.print("\n\n ***** Login Menu *****\n");
    	System.out.println("\n1) Login \n2) Exit");
    	System.out.print(" > ");
    	//prompt the user
    	strchoice = input.next();

    	//method call validation
    	choice = validationcho(strchoice);

    	//if the user enters 1
    	if(choice == 1){
    		System.out.print("\nEnter Pin: ");
    		//prompt the user
    		strpin = input.next();
    		//method call validation
    		pin = validationpin(strpin);
    		//check if pin is in the array
    		for(int i=0;i<pins.length;i++){
    			if(pin==pins[i]){
    				System.out.print("\n*** PIN FOUND ***");
    				System.out.println();	//print blank line
    				//change found to true
    				found = true;
    				//hold onto the subscript
    				sub = i;
    				break;
    			}//end if
    		}//end for

    		//check if found is still false
    		if(found==false ){
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			System.out.println("\nPin was not found...");
    			loginmenu();	//reprint login menu
    		}//end if
    		else{
    			//call method ATMMenu
    			ATMMenu(sub);
    		}//end else
    	}//end choice 1

    	if(choice == 2){
    		//call method quit
    		quit();
    	}//end choice 2

    }//end loginmenu method

    /***** QUIT METHOD *****/
    public static void quit(){
    	System.out.print("\nThank you for using our ATM... \n\n...Goodybe\n\n\n");
    	System.exit(0);
    }//end quit method

    /***** ATM MENU METHOD *****/
    public static void ATMMenu(int msub){
    	String strmenuselect, strpin2, strlodgement, strwithdrawal;
    	int menuselect =0, lodgement, withdrawal, pin2;

    	System.out.println("\nWelcome " + names[msub] + " to: Bank of Ireland ATM Machine.");
    	System.out.println("Current Balance: " + balance[msub]);
    	if(overdraft[sub]==1){
    		System.out.println("Overdraft Av/NA: Available");
    	}//end if
    	else{
    		System.out.println("Overdraft Av/NA: Not Available");
    	}//end else

    	while(menuselect!=4){
    		System.out.println("\n1) Lodge \n2) Withdraw \n3) Change Pin \n4) Quit");
    		System.out.print(" > ");
    		//prompt user
    		strmenuselect = input.next();
    		//method call validate
    		menuselect = menuvalidation(strmenuselect);

    		//choices
    		if(menuselect == 1){
    			System.out.print("\nEnter Lodgement: ");
    			strlodgement = input.next();
    			//method call lodgevalidation
    			lodgement = lodgevalidation(strlodgement);
    			//method call lodge
    			lodge(lodgement);
    		}//end choice 1
    		else if(menuselect == 2){
    			System.out.print("\nEnter Withdrawal: ");
    			strwithdrawal = input.next();
    			//method call withdrawvalidation
				withdrawal = withdrawvalidation(strwithdrawal);
    			//method call withdraw
    			withdraw(withdrawal);
    		}//end choice 2
    		else if(menuselect == 3){
    			System.out.print("\nEnter NEW PIN: ");
    			strpin2 = input.next();
    			//method call selection validation
    			pin2 = changepinval(strpin2);
    			//method call newpin and have the new pin returned to the method call
    			pins[sub]=newpin(pin2);
    		}//end choice 3
    	}//end while

    	//method call to end program
    	System.out.print("\nYou have logged out.");
    	loginmenu();

    }//end atmmenu method

    /***** LODGEMENT METHOD *****/
    public static int lodge(int mlodgement){
    	balance[sub] += mlodgement;
    	//show the user their updated details
		System.out.println("\n*** LODGEMENT SUCCESSFUL ***");
		System.out.println("\nLogged in as: " + names[sub]);
    	System.out.println("New Balance: " + balance[sub]);
    	if(overdraft[sub]==1){
    		System.out.println("Overdraft Av/NA: Available");
    	}//end if
    	else{
    		System.out.println("Overdraft Av/NA: Not Available");
    	}//end else
    	return mlodgement;
    }//end lodge method

    /***** WITHDRAWAL METHOD *****/
    public static int withdraw(int mwithdrawal){
		//if they don't have an overdraft
    	if(overdraft[sub]==0){
    		if(balance[sub] < mwithdrawal){
    			java.awt.Toolkit.getDefaultToolkit().beep();
    			System.out.print("\nERROR: INSUFFICIENT FUNDS\n");
    		}//end if
    		else{
    			balance[sub]-=mwithdrawal;
    			System.out.println("\n*** WITHDRAWAL SUCCESSFUL ***");
    			//show the user their updated details
				System.out.println("\nLogged in as: " + names[sub]);
    			System.out.println("New Balance: " + balance[sub]);
    			if(overdraft[sub]==1){
    				System.out.println("Overdraft Av/NA: Available");
    			}//end inner if
    			else{
    				System.out.println("Overdraft Av/NA: Not Available");
    			}//end inner else
    			return mwithdrawal;
    		}//end outer else
    	}//end outer if
    	//else if they have an overdraft
    	else if(overdraft[sub]==1){
    		balance[sub]-=mwithdrawal;
    		System.out.println("\n*** WITHDRAWAL SUCCESSFUL ***");
    		//show the user their updated details
			System.out.println("\nLogged in as: " + names[sub]);
    		System.out.println("New Balance: " + balance[sub]);
    		if(overdraft[sub]==1){
    			System.out.println("Overdraft Av/NA: Available");
    		}//end if
    		else{
    			System.out.println("Overdraft Av/NA: Not Available");
    		}//end else
    		return mwithdrawal;
    	}//end else if
    	return mwithdrawal;
    }//end withdrawal method

    /***** CHANGE PIN METHOD *****/
    public static int newpin(int mpin2){
    	String strpin2;
  		//set found to false
    	found = false;
		while(found == false){
    		for(int i=0;i<pins.length;i++){
    			if(mpin2==pins[i]){
    				java.awt.Toolkit.getDefaultToolkit().beep();
    				System.out.println("\n*** PIN IN USE ***");
    				//set found to false
    				found = false;
    				System.out.print("\nEnter NEW PIN: ");
    				//reprompt the user
    				strpin2 = input.next();
    				//method call changepinval
    				mpin2 = changepinval(strpin2);
    				i = 0;
    				sub = i;
    				break;
    			}//end if
    			else{
    				found = true;
    			}//end else
    	 	}//end for
		}//end while

		if(found==true){
			System.out.println("\n*** PIN CHANGED ***");
			//show the user their updated details
			System.out.println("\nLogged in as: " + names[sub]);
    		System.out.println("New Balance: " + balance[sub]);
    		if(overdraft[sub]==1){
    			System.out.println("Overdraft Av/NA: Available");
    		}//end if
    		else{
    			System.out.println("Overdraft Av/NA: Not Available");
    		}//end else
		}//end if

    	return mpin2;
    }//end newpin method

    /******************************/
    /***** VALIDATION METHODS *****/
    /******************************/

    /***** LOGIN MENU VALIDATION *****/
    public static int validationcho(String a){
    	//choice validation
    	while(!a.matches("[1-2]")){
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		System.out.println("\nERROR: Please Enter Valid Options ONLY");
    		//reprompt the user
    		System.out.println("\n1) Login \n2) Exit");
    		System.out.print(" > ");
    		a = input.next();
    	}//end choice validation
    	return Integer.parseInt(a);
    }//end login menu validation

    /***** PIN VALIDATION *****/
    public static int validationpin(String b){
    	while(!b.matches("\\d{3}")){
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		System.out.println("\nERROR: 3 Digits ONLY");
    		//reprompt the user
    		System.out.print("\nEnter Pin: ");
    		//prompt the user
    		b = input.next();
    	}//end pin validation
    	return Integer.parseInt(b);
    }//end validation

    /***** MAIN MENU VALIDATION *****/
    public static int menuvalidation(String c){
    	//choice validation
    	while(!c.matches("[1-4]")){
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		System.out.println("\nERROR: Please Enter Valid Options ONLY");
    		//reprompt the user
    		System.out.println("\n1) Lodge \n2) Withdraw \n3) Change Pin \n4) Quit");
    		System.out.print(" > ");
    		c = input.next();
    	}//end choice validation
    	return Integer.parseInt(c);
    }//end login menu validation

    /***** CHANGE PIN VALIDATION *****/
    public static int changepinval(String x){
    	while(!x.matches("\\d{3}")){
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		System.out.print("\n* ERROR: 3 Digits ONLY *");
    		//reprompt the user
    		System.out.print("\n\nEnter NEW PIN: ");
    		x = input.next();
    	}//end while
    	return Integer.parseInt(x);
    }//end changepinval method

	/***** LODGEMENT VALIDATION *****/
    public static int lodgevalidation(String y){
    	while(!y.matches("(\\d+)")){
    		java.awt.Toolkit.getDefaultToolkit().beep();
    		System.out.print("\n* ERROR: Digits ONLY *");
    		//reprompt the user
    		System.out.print("\n\nEnter Lodgement: ");
    		y = input.next();
    	}//end while
    	return Integer.parseInt(y);
    }//end lodgevalidation

	/***** WITHDRAWAL VALIDATION *****/
	public static int withdrawvalidation(String z){
		while(!z.matches("(\\d+)")){
			java.awt.Toolkit.getDefaultToolkit().beep();
			System.out.print("\n* ERROR: Digits ONLY *");
			//reprompt user
			System.out.print("\n\nEnter Withdrawal: ");
			z = input.next();
		}//end while
		return Integer.parseInt(z);
	}//end withdrawvalidation

}//end class