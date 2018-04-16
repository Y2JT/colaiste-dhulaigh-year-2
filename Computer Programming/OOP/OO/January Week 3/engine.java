/**
 * @(#)engine.java
 *
 *
 * @author
 * @version 1.00 2016/1/21
 */


public class engine {

	//attributes
	private String fueltype;
	private int enginesize;

    public engine(int es, String ft) {
    	setDetails(es,ft);
    }//end constructor

    public void setDetails(int es, String ft){
    	this.enginesize = ((es > 500)? es : 1);
    	this.fueltype = ((ft.length()>0)? ft : "Unknown");
    }//end setDetails

    //toString
    public String toString(){
    	return "\nFuel Type: " + fueltype + "\nEngine Size: " + enginesize;
    }//end toString

}//end class