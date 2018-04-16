/**
 * @(#)animalTest.java
 *
 *
 * @author
 * @version 1.00 2016/2/26
 */


public class animalTest {

    public static void main(String args[]) {

    	//create animal object array
    	animal a[] = new animal[3];

    	//populate array
    	a[0] = new animal("Rommel","Tricolour");
    	a[1] = new landAnimal("Patton","Tricolour",4,"Dog");
    	a[2] = new waterAnimal("Jaws","White",15,60);

    	for(int i = 0;i<a.length;i++){
    		System.out.println("\nAnimal " + (i+1));
    		System.out.print(a[i].toString());
    	}//end for

    }//end main


}//end class