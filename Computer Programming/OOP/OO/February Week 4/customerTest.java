/**
 * @(#)customerTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/25
 */


public class customerTest {

    public static void main(String args[]) {

    	//create customer object array
    	PolyCustomer c[] = new PolyCustomer[3];

		//populate array
    	c[0] = new PolyCustomer("Joey","Dublin");
    	c[1] = new premCustomer("Renee","Cork",1200);
    	c[2] = new busCustomer("Tom","Meath",343,"Sophie");

    	for(int i = 0;i<c.length;i++){
    		//System.out.print("\nCustomer " + (i+1));
    		System.out.print(c[i].toString());
    	}//end for

    }//end method

}//end class