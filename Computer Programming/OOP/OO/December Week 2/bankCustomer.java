/**
 * @(#)bankCustomer.java
 * Have a bank customer with name, account number, balance, address and overdraft
 * Create a customer with all details
 * Create a customer with only name and account number
 *
 * @author
 * @version 1.00 2015/12/11
 */


public class bankCustomer {

	private int balance, account_number;
	private String name, address;
	private boolean overdraft;

	//constructor with all details
    public bankCustomer(String n, String a, int b, int ac, boolean od) {
    	name = ((n.length()>0)?n : "Unknown");
    	address = ((a.length()>0)?a : "Uknown");
    	balance = b;
    	account_number = ac;
    	overdraft = od;
    }//end constructor

    //constructor with name and account number only
    public bankCustomer(String n, int ac){
    	name = ((n.length()>0)?n : "Unknown");
    	address = "Unknown";
    	balance = 0;
    	account_number = ac;
    	overdraft = false;
    }//end constructor

    //constructor with name, address and account number
    public bankCustomer(String n, String a, int ac){
    	name = ((n.length()>0)?n : "Unknown");
    	address = ((a.length()>0)?a : "Uknown");
    	balance = 0;
    	account_number = ac;
    	overdraft = false;
    }//end constructor

    //toString method
    public String toString(){
    	return "\nName: " + name + "\nAddress: " + address + "\nAccount Number: " + account_number +
    			"\nBalance: " + balance + "\nOverdraft: " + overdraft;
    }//end toString method


}//end class