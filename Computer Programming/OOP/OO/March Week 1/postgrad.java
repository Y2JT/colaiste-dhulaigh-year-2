/**
 * @(#)postgrad.java
 *
 *
 * @author
 * @version 1.00 2016/3/3
 */


public class postgrad extends student{

	private String degreeType;
	private int grade;

    public postgrad(String n, int i, phone p, String degree, int g) {
    	super(n,i,p);	//calls superclass constructor
    	degreeType = ((degree.length()>0)? degree : "Unknown");
    	grade = ((g>0)? g : 111);
    }//end constructor

    //toString
    public String toString(){
    	return super.toString() + "\nDegree Type: " + degreeType + "\nGrade: " + grade;
    }//end toString

}//end class