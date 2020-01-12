#ifndef BATTLESHIPMODEL_H
#define BATTLESHIPMODEL_H

#include <QAbstractTableModel>
#include <QRandomGenerator>

enum class Status {
    NOTHING,
    MISSED,
    HIT,
    SHIP
};

enum class BoardType {
    PLAYER,
    ENEMY
};

Q_DECLARE_METATYPE(Status)

struct Tile {
    Status tileStatus{Status::NOTHING};
};

class BattleshipModel : public QAbstractTableModel
{
    Q_OBJECT

public:
    explicit BattleshipModel(BoardType type, QObject *parent = nullptr);

    // Header:
    QVariant headerData(int section, Qt::Orientation orientation, int role = Qt::DisplayRole) const override;

    bool setHeaderData(int section, Qt::Orientation orientation, const QVariant &value, int role = Qt::EditRole) override;

    // Basic functionality:
    int rowCount(const QModelIndex &parent = QModelIndex()) const override;
    int columnCount(const QModelIndex &parent = QModelIndex()) const override;

    QVariant data(const QModelIndex &index, int role = Qt::DisplayRole) const override;

    // Editable:
    bool setData(const QModelIndex &index, const QVariant &value,
                 int role = Qt::EditRole) override;

    Qt::ItemFlags flags(const QModelIndex& index) const override;

    int carrierCount() const { return missingCarrier; }
    int battleshipCount() const { return missingBattleship; }
    int destroyerCount() const { return missingDestroyer; }
    int corvetteCount() const { return missingCorvette; }

    void lowerCarrierCount() { if(missingCarrier) --missingCarrier; }
    void lowerBattleshipCount() { if(missingBattleship) --missingBattleship; }
    void lowerDestroyerCount() { if(missingDestroyer) --missingDestroyer; }
    void lowerCorvetteCount() { if(missingCorvette) --missingCorvette; }

    bool isReady() const { return ready; }
    void setReady(bool value) { ready = value; }
    bool checkReady() const { return (!missingCarrier && !missingBattleship && !missingDestroyer && !missingCorvette); }

    void lowerMissedSquares() { if(missedSquares) --missedSquares; }
    bool checkVictory() const { return !missedSquares; }

    BoardType getType() const { return type; }

    bool checkNeighbours(int row, int column) const;

    bool hasWon() const { return won; }

    void clearTiles();
    void clearModel();

public slots:
    void playGame();
    void makeShot(const QModelIndex& index);
    void randomShot();

signals:
    void enemysTurn();
    void playersTurn();
    void gameWon();
    void gameLost();

private:
    int missingCarrier{1};
    int missingBattleship{2};
    int missingDestroyer{3};
    int missingCorvette{4};
    int missedSquares{30};
    bool ready{ false };
    bool won{ false };
    BoardType type;
    QVector<Tile> tiles;

    void setEnemyHardcoded();
};

#endif // BATTLESHIPMODEL_H
