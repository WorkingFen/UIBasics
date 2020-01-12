#include "battleshipmodel.h"

BattleshipModel::BattleshipModel(BoardType type, QObject *parent): QAbstractTableModel(parent), type(type) {
    for(int i = 0; i < 100; ++i)
        tiles.append(Tile());
    if(type == BoardType::ENEMY)
        setEnemyHardcoded();
}

QVariant BattleshipModel::headerData(int section, Qt::Orientation orientation, int role) const {
    if(role == Qt::DisplayRole && orientation == Qt::Horizontal) {
        return QString("%1")
                .arg(section);
    }
    else if(role == Qt::DisplayRole && orientation == Qt::Vertical) {
        return QString("%1")
                .arg(static_cast<char>(section+'A'));
    }
    return QVariant();
}

bool BattleshipModel::setHeaderData(int section, Qt::Orientation orientation, const QVariant &value, int role) {
    if(value != headerData(section, orientation, role)) {
        emit headerDataChanged(orientation, section, section);
        return true;
    }
    return false;
}

int BattleshipModel::rowCount(const QModelIndex& /*parent*/) const {
    return 10;
}

int BattleshipModel::columnCount(const QModelIndex& /*parent*/) const {
    return 10;
}

QVariant BattleshipModel::data(const QModelIndex &index, int role) const {
    if(role == Qt::DisplayRole) {
        if(tiles.at(10*index.row() + index.column()).tileStatus == Status::HIT) {
            return QString("X");
        }
        else if(tiles.at(10*index.row() + index.column()).tileStatus == Status::SHIP) {
            if(type == BoardType::PLAYER)
                return QString("#");
            else
                return QString("");
        }
        else if(tiles.at(10*index.row() + index.column()).tileStatus == Status::MISSED) {
            return QString("~");
        }
        else {
            return QString("");
        }
        //return QVariant::fromValue(tiles[index.row()][index.column()].tileStatus);
    }
    return QVariant();
}

bool BattleshipModel::setData(const QModelIndex &index, const QVariant &value, int role) {
    if(data(index, role) != value) {
        tiles[10*index.row()+index.column()].tileStatus = static_cast<Status>(value.toInt());
        emit dataChanged(index, index, QVector<int>() << role);
        return true;
    }
    return false;
}

Qt::ItemFlags BattleshipModel::flags(const QModelIndex& /*index*/) const {
    if((type == BoardType::PLAYER && ready) || (type == BoardType::ENEMY && !ready))
        return Qt::NoItemFlags;

    if(type == BoardType::PLAYER)
        return Qt::ItemIsSelectable | Qt::ItemIsEnabled;
    else
        return Qt::ItemIsEnabled;
}

void BattleshipModel::playGame() {
    setReady(true);
}

void BattleshipModel::makeShot(const QModelIndex& index) {
    Status actualTilesStatus = tiles.at(10*index.row()+index.column()).tileStatus;
    if(actualTilesStatus == Status::NOTHING) {
        setData(index, QVariant::fromValue(Status::MISSED));
        setReady(false);
        emit enemysTurn();
    }
    else if(actualTilesStatus == Status::SHIP) {
        setData(index, QVariant::fromValue(Status::HIT));
        lowerMissedSquares();
        if(checkVictory()) {
            emit gameWon();
            return;
        }
        setReady(false);
        emit enemysTurn();
    }
}

void BattleshipModel::randomShot() {
    int row;
    int col;
    Status actualTilesStatus;
    do{
        row = static_cast<int>(QRandomGenerator::global()->bounded(10));
        col = static_cast<int>(QRandomGenerator::global()->bounded(10));
        actualTilesStatus = tiles.at(10*row+col).tileStatus;
    }while(actualTilesStatus != Status::NOTHING && actualTilesStatus != Status::SHIP);
    if(actualTilesStatus == Status::NOTHING)
        setData(this->index(row, col), QVariant::fromValue(Status::MISSED));
    else if(actualTilesStatus == Status::SHIP) {
        setData(this->index(row, col), QVariant::fromValue(Status::HIT));
        lowerMissedSquares();
        if(checkVictory()) {
            emit gameLost();
            return;
        }
    }
    emit playersTurn();
}

bool BattleshipModel::checkNeighbours(int row, int col) const {
    for(int i = -1; i < 2; ++i)
        for(int j = -1; j < 2; ++j)
            if(row+i >= 0 && col+j >= 0 && row+i <= 9 && col+j <= 9)
                if(tiles.at(10*(row+i) + col+j).tileStatus != Status::NOTHING)
                    return false;
    return true;
}

void BattleshipModel::clearTiles() {
    tiles.clear();
    for(int i = 0; i < 100; ++i)
        tiles.append(Tile());
    if(type == BoardType::ENEMY)
        setEnemyHardcoded();
    emit dataChanged(this->index(0,0), this->index(9,9));
}

void BattleshipModel::clearModel() {
    clearTiles();
    missingCarrier = 1;
    missingBattleship = 2;
    missingDestroyer = 3;
    missingCorvette = 4;
    missedSquares = 30;
    ready = false;
    won = false;
}

void BattleshipModel::setEnemyHardcoded() {
    setData(this->index(0,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(1,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(2,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(3,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(4,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(0,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(1,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(2,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(3,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(0,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(1,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(2,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(3,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(0,6), QVariant::fromValue(Status::SHIP));
    setData(this->index(1,6), QVariant::fromValue(Status::SHIP));
    setData(this->index(2,6), QVariant::fromValue(Status::SHIP));
    setData(this->index(0,8), QVariant::fromValue(Status::SHIP));
    setData(this->index(1,8), QVariant::fromValue(Status::SHIP));
    setData(this->index(2,8), QVariant::fromValue(Status::SHIP));
    setData(this->index(4,6), QVariant::fromValue(Status::SHIP));
    setData(this->index(4,7), QVariant::fromValue(Status::SHIP));
    setData(this->index(4,8), QVariant::fromValue(Status::SHIP));
    setData(this->index(6,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(7,0), QVariant::fromValue(Status::SHIP));
    setData(this->index(6,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(7,2), QVariant::fromValue(Status::SHIP));
    setData(this->index(6,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(7,4), QVariant::fromValue(Status::SHIP));
    setData(this->index(6,6), QVariant::fromValue(Status::SHIP));
    setData(this->index(7,6), QVariant::fromValue(Status::SHIP));
}
