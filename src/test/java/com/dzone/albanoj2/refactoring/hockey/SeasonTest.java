package com.dzone.albanoj2.refactoring.hockey;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class SeasonTest {
    private Season season;
    private static final double TOLERANCE = 0.000001;


    @Before
    public void setUp() {
        season = new Season();
    }

    @Test
    public void test_AddGame(){
        Game game = new Game (2,3,6);
        season.addGame (game);
        Assert.assertEquals (season.getGames ().get (0), game);
    }

    @Test
    public void test_VerifyTheGoalieStatistics(){
        Game game = new Game (2,3,6);
        season.addGame (game);
        Assert.assertEquals (season.getGoalieStatistics ().getSavePercentage (), new GoalieStatistics (season).getSavePercentage (), TOLERANCE);
    }
}
