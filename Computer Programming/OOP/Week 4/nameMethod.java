/**
 * @(#)nameMethod.java
 *
 *
 * @author
 * @version 1.00 2015/10/8
 */


public class nameMethod {

    public static void main(String args[]) {

    	//method call
    	printname();
    	printname("Joey Tierney");

    }//end main method


    //method with no parameters
    public static void printname(){
    for(int i = 1;i <=10; i++){
    	System.out.println("Joey");
    }//end for

  }//end printname method

  //method with one parameter
  public static void printname(String x){
  	for(int i = 1;i <=10; i++){
    	System.out.println(x);
  	}//end for
  }//end printname

}//end class