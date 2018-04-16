/**
 * @(#)teamTest.java
 * teamTest to go with team.java
 *
 * @author
 * @version 1.00 2015/12/10
 */

import java.util.Scanner;
public class teamTest {

    public static void main(String args[]) {

    	Scanner input = new Scanner(System.in);

    	String name;
    	int league_position, num_goals;

    	//take inputs for object
    	System.out.print("Enter Team Name: ");
    	name = input.nextLine();
    	System.out.print("\nEnter League Position: ");
    	league_position = input.nextInt();
    	System.out.print("\nEnter Number of Goals: ");
    	num_goals = input.nextInt();

    	team t1 = new team(name,league_position,num_goals);

    	//print team details
    	System.out.println(t1.toString());

    	//change details using setmethods
    	t1.setname("Borussia Dortmund");
    	t1.setleague(2);
    	t1.setgoals(23);

    	//print updated details using getmethods
    	System.out.println("\nNew Details for Team: ");
    	System.out.print("\nTeam Name: " + t1.getname());
    	System.out.print("\nLeague Position: " + t1.getleague());
    	System.out.print("\nNumber of Goals: " + t1.getgoals() + "\n\n");

    }//end main method


}//end class