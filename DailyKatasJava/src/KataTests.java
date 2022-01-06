import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class KataTests {
    @Test
    void highAndLow_MultiNums() {
        assertEquals("42 -9", Kata.highAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }

    @Test
    void highAndLow_OneNum() {
        assertEquals("5 5", Kata.highAndLow("5"));
    }

    @Test
    void highAndLow_MultiNumsPositive() {
        assertEquals("42 1", Kata.highAndLow("8 3 5 42 1 9 4 7 4 4"));
    }
}
