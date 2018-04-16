/**
 * @(#)timeTest.java
 *
 *
 * @author
 * @version 1.00 2015/12/11
 */


public class timeTest {

    public static void main(String args[]) {

    	time t1 = new time();
    	time t2 = new time(12);
    	time t3 = new time(12,44);
    	time t4 = new time(12,44,56);
    	time t5 = new time(t4);

    	System.out.println(t1.toString());
    	System.out.println(t2.toString());
    	System.out.println(t3.toString());
    	System.out.println(t4.toString());
    	System.out.println(t5.toString() + "\n\n");

    }//end main method


}//end class