#ifndef GAMEWINDOW_H
#define GAMEWINDOW_H

#include "battleshipmodel.h"
#include "ui_gamewindow.h"
#include "board.h"

#include <QMainWindow>
#include <QResizeEvent>
#include <QMouseEvent>
#include <QDebug>

QT_BEGIN_NAMESPACE
namespace Ui {
    class GameWindow;
}
QT_END_NAMESPACE

class GameWindow : public QMainWindow {
    Q_OBJECT

public:
    GameWindow(QWidget *parent = nullptr);
    ~GameWindow() override;

public slots:
    void newGame();
    void changeStackedIndex();
    void undoPlayer();
    void changeText();
    void enableUndoButton();
    void enableReadyButton();
    void playGame();
    void gameWon();
    void gameLost();

protected:
    void resizeEvent(QResizeEvent *event) override;

private:
    Ui::GameWindow* ui;
    BattleshipModel* playerModel;
    BattleshipModel* enemyModel;
    QItemSelectionModel* playerSelection;

    void setTables(QTableView* table, BattleshipModel* model);
    void changeContentSize();

};

#endif // GAMEWINDOW_H
