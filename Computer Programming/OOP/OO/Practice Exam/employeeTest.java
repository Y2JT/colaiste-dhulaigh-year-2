/**
 * @(#)employeeTest.java
 *
 *
 * @author 
 * @version 1.00 2016/3/2
 */


public class employeeTest {

    public static void main(String args[]) {
    	
    	//create employee object
    	employee e1 = new employee("Joey","Dublin",541);
    	
    	System.out.print(e1.toString());
    	
    	//set new details
    	e1.setname("John");
    	e1.setid(370);
    	
    	//print new details
    	System.out.print("\nNew employee details: " + e1.toString());
    
    }
    
    
}