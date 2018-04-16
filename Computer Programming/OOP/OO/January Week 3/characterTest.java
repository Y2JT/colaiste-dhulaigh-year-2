/**
 * @(#)characterTest.java
 *
 *
 * @author
 * @version 1.00 2016/1/22
 */


public class characterTest {

    public static void main(String args[]) {

    	soldier s1 = new soldier("Ted", 12, 6.1, 528, "Sgt.");
    	System.out.println(s1.toString());
    	System.out.println("Number of characters are: " + s1.getcount());

		wizard w1 = new wizard("Rumpelstiltskin", 88, 7.6, "Orphan", "Not the colour of love");
    	System.out.println(w1.toString());
    	System.out.println("Number of characters are: " + s1.getcount() + "\n");

    }//end main

}//end class