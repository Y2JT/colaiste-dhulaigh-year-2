/**
 * @(#)time.java
 * Create a time object that can be set with knowing;
 * no arguments
 * hour
 * hour and minute
 * hour, minute and second
 * time object
 *
 * @author
 * @version 1.00 2015/12/11
 */


public class time {

	 private int hour, minute, second;

	//constructor with no arguments
    public time() {
    	setDetails(0,0,0);
    }//end constructor

    //constructor with hour argument
    public time(int h){
    	setDetails(h,0,0);
    }//end constructor

    //constructor with hour and minute arguments
    public time(int h, int m){
    	setDetails(h,m,0);
    }//end constructor

    //constructor with hour, minute and second arguments
    public time(int h, int m, int s){
    	setDetails(h,m,s);
    }//end constructor

    //get hour
    public int gethour(){
    	return hour;
    }//end get hour

    //get minute
    public int getminute(){
    	return minute;
    }//end get minute

    //get second
    public int getsecond(){
    	return second;
    }//end getsecond

    //constructor with time object
    public time(time t){
    	setDetails(t.gethour(), t.getminute(), t.getsecond());
    }//end constructor

    public void setDetails(int h, int m, int s){
    	hour = ((h>=0 && h<24)?h : 0);
    	minute = ((m>=0 && m<=59)?m : 0);
    	second = ((s>=0 && s<=59)?s : 0);
    }//end setDetails

    //toString method
    public String toString(){
    	return "Time is: " + hour + ":" + minute + ":" + second;
    }//end toString


}//end class