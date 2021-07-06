#ifndef ROCKPAPERSCISSORS_H
#define ROCKPAPERSCISSORS_H

typedef enum {PLAYER1, PLAYER2, TIE} rps_winner_t;
typedef enum {ROCK, PAPER, SCISSORS} rps_gesture_t;

rps_winner_t rock_paper_scissors(rps_gesture_t player1, rps_gesture_t player2);

#endif
