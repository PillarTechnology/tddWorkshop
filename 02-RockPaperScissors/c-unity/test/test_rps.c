#include "unity.h"
#include "rockpaperscissors.h"

void test_Player1RockBeatsPlayer2Scissors(void) {
  TEST_ASSERT_EQUAL_INT(PLAYER1, rock_paper_scissors(ROCK, SCISSORS));
}

int main(void) {
  UNITY_BEGIN();

  RUN_TEST(test_Player1RockBeatsPlayer2Scissors);

  return UNITY_END();
}
