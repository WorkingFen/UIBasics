#ifndef BOARD_H
#define BOARD_H

#include "battleshipmodel.h"

#include <QTableView>
#include <QMouseEvent>
#include <QDebug>

class Board : public QTableView {
    Q_OBJECT
public:
    Board();
    Board(QWidget* parent);

    void mouseReleaseEvent(QMouseEvent* event) override;

signals:
    void newShip();
};

#endif // BOARD_H
