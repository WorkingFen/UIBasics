#include "board.h"

Board::Board() {}
Board::Board(QWidget* parent) :QTableView(parent) {}

void Board::mouseReleaseEvent(QMouseEvent* event) {
    if(event->button() == Qt::LeftButton) {
        BattleshipModel* gameModel = static_cast<BattleshipModel*>(model());
        QModelIndexList select = selectionModel()->selectedIndexes();

        int noSelection{select.count()};

        if(gameModel->getType() == BoardType::PLAYER && noSelection) {
            if(noSelection >= 2 && noSelection <= 5) {
                int prevRow{select.at(0).row()};
                int prevCol{select.at(0).column()};
                bool same{true};
                bool changed{false};

                for(auto selection : select) {
                    if((prevRow != selection.row() && prevCol != selection.column()) || !gameModel->checkNeighbours(selection.row(), selection.column()))
                        same = false;
                }
                if(same){
                    switch(noSelection) {
                        case 2: {
                            if((changed = gameModel->corvetteCount()))
                                gameModel->lowerCorvetteCount();
                            break;
                        }
                        case 3: {
                            if((changed = gameModel->destroyerCount()))
                                gameModel->lowerDestroyerCount();
                            break;
                        }
                        case 4: {
                            if((changed = gameModel->battleshipCount()))
                                gameModel->lowerBattleshipCount();
                            break;
                        }
                        case 5: {
                            if((changed = gameModel->carrierCount()))
                                gameModel->lowerCarrierCount();
                            break;
                        }
                        default:
                            break;
                    }
                    if(changed) {
                        for(auto selection : select)
                            gameModel->setData(selection, QVariant::fromValue(Status::SHIP));
                        emit newShip();
                    }
                }
            }
            selectionModel()->clear();
        }
    }
}
