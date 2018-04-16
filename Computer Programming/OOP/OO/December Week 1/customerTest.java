/**
 * @(#)customerTest.java
 * customerTest to go with customer.java
 *
 * @author
 * @version 1.00 2015/12/4
 */


public class customerTest {

    public static void main(String args[]) {
    	//valid customer
    	customer c1 = new customer("Joey", 142, "Dublin");
    	//invalid customer
    	customer c2 = new customer("Harry", -45, "");

    	//print customer details
    	System.out.println(c1.toString());
    	System.out.println(c2.toString());

    	//change c1 name
    	c1.setname("Joey Tierney");
    	c1.setid(590);
    	c1.setaddress("Ballymun");

    	//print change
    	System.out.println("\nName after change is " + c1.getname());
    	System.out.println("ID after change is " + c1.getid());
    	System.out.println("Address after change is " + c1.getaddress() + "\n\n");

    }//end main method


}//end class