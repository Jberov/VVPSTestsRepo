package com.dzone.albanoj2.refactoring.hockey;

import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

public class GameTest {
    private Game game;
    private static final double TOLERANCE = 0.000001;

    @Before
    public void setUp(){
        game = new Game (3,8,56.70);
    }

    @Test
    public void test_getShotsOnGoalAgainst(){
        Assert.assertEquals (game.getShotsOnGoalAgainst (), 8);
    }

    @Test
    public void test_getGoals(){
        Assert.assertEquals (game.getGoalsAgainst (), 3);
    }

    @Test
    public void test_getMinutes(){
        Assert.assertEquals (game.getMinutesPlayed (), 56.70, TOLERANCE);
    }
}
