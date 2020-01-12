#include "gamewindow.h"

GameWindow::GameWindow(QWidget *parent): QMainWindow(parent), ui(new Ui::GameWindow) {
    ui->setupUi(this);
    ui->mainStackedWidget->setCurrentIndex(0);
    ui->menuShips->setEnabled(false);
    playerModel = new BattleshipModel(BoardType::PLAYER);
    enemyModel = new BattleshipModel(BoardType::ENEMY);
    setTables(ui->playerBoard, playerModel);
    setTables(ui->enemyBoard, enemyModel);
    changeContentSize();
    connect(ui->playButton, &QPushButton::clicked, this, &GameWindow::newGame);
    connect(ui->actionNew_game, &QAction::triggered, this, &GameWindow::newGame);
    connect(ui->undoButton, &QPushButton::clicked, this, &GameWindow::undoPlayer);
    connect(ui->playerBoard, &Board::newShip, this, &GameWindow::changeText);
    connect(ui->playerBoard, &Board::newShip, this, &GameWindow::enableUndoButton);
    connect(ui->playerBoard, &Board::newShip, this, &GameWindow::enableReadyButton);
    connect(ui->readyButton, &QPushButton::clicked, playerModel, &BattleshipModel::playGame);
    connect(ui->readyButton, &QPushButton::clicked, enemyModel, &BattleshipModel::playGame);
    connect(ui->readyButton, &QPushButton::clicked, this, &GameWindow::playGame);
    connect(ui->readyButton, &QPushButton::clicked, this, &GameWindow::changeText);
    connect(ui->enemyBoard, &QTableView::pressed, enemyModel, &BattleshipModel::makeShot);
    connect(enemyModel, &BattleshipModel::enemysTurn, playerModel, &BattleshipModel::randomShot);
    connect(playerModel, &BattleshipModel::playersTurn, enemyModel, &BattleshipModel::playGame);
    connect(enemyModel, &BattleshipModel::gameWon, this, &GameWindow::gameWon);
    connect(playerModel, &BattleshipModel::gameLost, this, &GameWindow::gameLost);
}

GameWindow::~GameWindow() {
    delete ui;
}

void GameWindow::setTables(QTableView* table, BattleshipModel* model) {
    table->setModel(model);
    table->horizontalHeader()->setSectionResizeMode(QHeaderView::Stretch);
    table->verticalHeader()->setSectionResizeMode(QHeaderView::Stretch);
    table->horizontalHeader()->setEnabled(false);
    table->verticalHeader()->setEnabled(false);
    table->horizontalHeader()->setSectionsClickable(false);
    table->verticalHeader()->setSectionsClickable(false);
    table->setEditTriggers(QAbstractItemView::NoEditTriggers);
    table->setSelectionMode(QAbstractItemView::SelectionMode::MultiSelection);
    this->setStyleSheet("QHeaderView::section {"
                        "border-style: none;"
                        "border-bottom: 1px solid #fffff8;"
                        "border-right: 1px solid #fffff8;"
                        "}"
                        ""
                        "QHeaderView::section:horizontal {"
                        "border-top: 1px solid #fffff8;"
                        "}"
                        ""
                        "QHeaderView::section:vertical {"
                        "border-left: 1px solid #fffff8;"
                        "}");
}

void GameWindow::newGame() {
    if(ui->mainStackedWidget->currentIndex() == 0) {
        ui->menuShips->setEnabled(true);
        ui->mainStackedWidget->setCurrentIndex(1);
        ui->undoButton->setEnabled(false);
        ui->readyButton->setEnabled(false);
        ui->tips->setText(QString("Aye Captain! You have to place %1x Carrier, %2x Battleship, %3x Destroyer, %4x Corvette on battlefield on the left")
                          .arg(playerModel->carrierCount())
                          .arg(playerModel->battleshipCount())
                          .arg(playerModel->destroyerCount())
                          .arg(playerModel->corvetteCount()));
    }
    else {
        playerModel->clearModel();
        enemyModel->clearModel();
        ui->undoButton->setEnabled(false);
        ui->readyButton->setEnabled(false);
        ui->tips->setText(QString("Aye Captain! You have to place %1x Carrier, %2x Battleship, %3x Destroyer, %4x Corvette on battlefield on the left")
                          .arg(playerModel->carrierCount())
                          .arg(playerModel->battleshipCount())
                          .arg(playerModel->destroyerCount())
                          .arg(playerModel->corvetteCount()));
    }
}

void GameWindow::changeStackedIndex() {
    if(ui->mainStackedWidget->currentIndex() == 0) {
        ui->menuShips->setEnabled(true);
        ui->mainStackedWidget->setCurrentIndex(1);
    }
    else {
        ui->menuShips->setEnabled(false);
        ui->mainStackedWidget->setCurrentIndex(0);
    }
}

void GameWindow::playGame() {
    ui->undoButton->setEnabled(false);
    ui->readyButton->setEnabled(false);
}

void GameWindow::undoPlayer() {
    newGame();
}

void GameWindow::enableUndoButton() {
    if(!ui->undoButton->isEnabled())
        ui->undoButton->setEnabled(true);
}

void GameWindow::enableReadyButton() {
    if(playerModel->checkReady())
        ui->readyButton->setEnabled(true);
}

void GameWindow::changeText() {
    if(playerModel->checkReady()) {
        if(!playerModel->isReady())
            ui->tips->setText(QString("We are ready to sail!"));
        else
            ui->tips->setText(QString("Captain, our radar gone off! We have to take out enemy as soon as possible. \"Show us da wae\" on the right"));
    }
    else
        ui->tips->setText(QString("Aye Captain! You have to place %1x Carrier, %2x Battleship, %3x Destroyer, %4x Corvette on battlefield on the left")
                      .arg(playerModel->carrierCount())
                      .arg(playerModel->battleshipCount())
                      .arg(playerModel->destroyerCount())
                      .arg(playerModel->corvetteCount()));
}

void GameWindow::gameWon() {
    ui->tips->setText(QString("Congratulations Captain! You won naval battle!"));
    enemyModel->setReady(false);
}

void GameWindow::gameLost() {
    ui->tips->setText(QString("Captain! We lost all ships... We have been defeated!"));
    enemyModel->setReady(false);
}

void GameWindow::changeContentSize() {
    QFont f = ui->title->font();
    f.setPointSize(qMax(this->width(), this->height())/15);
    ui->title->setFont(f);

    f = ui->playButton->font();
    f.setPointSize(qMax(this->width(), this->height())/45);
    ui->playButton->setFont(f);
    ui->exitButton->setFont(f);

    f = ui->undoButton->font();
    f.setPointSize(qMax(this->width(), this->height())/85);
    ui->undoButton->setFont(f);
    ui->readyButton->setFont(f);

    f = ui->tips->font();
    f.setPointSize(qMax(this->width(), this->height())/95);
    ui->tips->setFont(f);

    f = ui->playerBoard->horizontalHeader()->font();
    f.setPointSize(qMin(this->width(), this->height())/75);
    ui->playerBoard->horizontalHeader()->setFont(f);
    ui->playerBoard->verticalHeader()->setFont(f);
    ui->enemyBoard->horizontalHeader()->setFont(f);
    ui->enemyBoard->verticalHeader()->setFont(f);

    ui->playerBoard->verticalHeader()->setDefaultAlignment(Qt::AlignCenter);
    ui->enemyBoard->verticalHeader()->setDefaultAlignment(Qt::AlignCenter);

    QSize s = ui->playButton->baseSize();
    s.scale(this->width()/5, this->height()/5, Qt::KeepAspectRatio);
    ui->playButton->setMinimumSize(s);
    ui->exitButton->setMinimumSize(s);

    s = ui->playButton->baseSize();
    s.scale(this->width()/8, this->height()/8, Qt::KeepAspectRatio);
    ui->undoButton->setMinimumSize(s);
    ui->readyButton->setMinimumSize(s);

    s = ui->playerBoard->baseSize();
    s.scale(this->width()*2/3, this->height()*2/3, Qt::KeepAspectRatio);
    ui->playerBoard->setMinimumSize(s);
    ui->enemyBoard->setMinimumSize(s);
}

void GameWindow::resizeEvent(QResizeEvent *event) {
    changeContentSize();
    QMainWindow::resizeEvent(event);
}
