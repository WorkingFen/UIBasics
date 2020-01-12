import QtQuick 2.12
import QtQuick.Window 2.12
import QtQuick.Controls.Material 2.0
import QtQuick.Controls 2.3

Window {
    id: window
    visible: true
    width: 990
    height: 500
    color: "#23232d"
    title: qsTr("BattleShips")

    Row {
        id: row
        anchors.rightMargin: 0
        anchors.bottomMargin: 0
        anchors.leftMargin: 0
        anchors.topMargin: 26
        anchors.fill: parent

        StackView {
            id: stackView
            anchors.leftMargin: 0
            anchors.top: parent.top
            anchors.right: parent.right
            anchors.bottom: parent.bottom
            anchors.left: parent.left
            anchors.topMargin: 0
            transformOrigin: Item.Left
            initialItem: welcomePage

            Page {
                id: welcomePage
                background: Rectangle {
                    color: "#23232d"
                }
                anchors.fill: parent

                Row {
                    id: welcomeRow
                    anchors.fill: parent

                    Label {
                        id: label
                        color: "#ffffff"
                        text: qsTr("BattleShips")
                        anchors.verticalCenterOffset: -Math.max(window.width, window.height)/15
                        anchors.horizontalCenterOffset: 0
                        transformOrigin: Item.TopLeft
                        anchors.horizontalCenter: parent.horizontalCenter
                        anchors.verticalCenter: parent.verticalCenter
                        font.pointSize: Math.max(window.width, window.height)/15
                        font.family: "Copperplate Gothic Bold"
                    }

                    Button {
                        id: exitButton
                        width: 165
                        height: 40
                        text: qsTr("Exit")
                        anchors.horizontalCenter: parent.horizontalCenter
                        anchors.verticalCenter: parent.verticalCenter
                        anchors.verticalCenterOffset: Math.max(window.width, window.height)/20*2
                        font.family: "Copperplate Gothic Bold"
                        font.pointSize: 20
                        scale: Math.max(window.width, window.height)/1000
                        onClicked: window.close()
                    }

                    Button {
                        id: playButton
                        width: 165
                        height: 40
                        text: qsTr("Play")
                        anchors.verticalCenterOffset: Math.max(window.width, window.height)/20
                        anchors.verticalCenter: parent.verticalCenter
                        anchors.horizontalCenter: parent.horizontalCenter
                        font.pointSize: 20
                        font.weight: Font.Normal
                        flat: false
                        autoExclusive: false
                        autoRepeat: false
                        display: AbstractButton.TextOnly
                        font.family: "Copperplate Gothic Bold"
                        scale: Math.max(window.width, window.height)/1000
                        onClicked: {
                            gamePage.visible = true
                            shipsButton.enabled = true
                            playButton.enabled = false
                            exitButton.enabled = false
                        }
                    }

                }
            }

            Page {
                id: gamePage
                visible: false
                background: Rectangle {
                    color: "#23232d"
                }
                anchors.fill: parent

                Row {
                    id: gameRow
                    anchors.fill: parent

                    Button {
                        id: undoButton
                        text: qsTr("Undo")
                        enabled: false
                        font.pointSize: 12
                        font.family: "Copperplate Gothic Bold"
                        anchors.bottom: parent.bottom
                        anchors.bottomMargin: Math.max(window.width, window.height)/25
                        anchors.left: parent.left
                        anchors.leftMargin: Math.max(window.width, window.height)/25
                        scale: Math.max(window.width, window.height)/1000
                    }

                    Button {
                        id: readyButton
                        text: qsTr("Ready")
                        enabled: false
                        font.pointSize: 12
                        font.family: "Copperplate Gothic Bold"
                        anchors.bottom: parent.bottom
                        anchors.bottomMargin: Math.max(window.width, window.height)/25
                        anchors.right: parent.right
                        anchors.rightMargin: Math.max(window.width, window.height)/25
                        scale: Math.max(window.width, window.height)/1000
                    }

                    Label {
                        id: tips
                        width: 690
                        height: 40
                        color: "#ffffff"
                        text: qsTr("Label")
                        verticalAlignment: Text.AlignVCenter
                        horizontalAlignment: Text.AlignHCenter
                        font.pointSize: 16
                        anchors.horizontalCenter: parent.horizontalCenter
                        anchors.bottom: parent.bottom
                        anchors.bottomMargin: Math.max(window.width, window.height)/25
                        scale: Math.max(window.width, window.height)/1000
                    }

                    GridView {
                        id: enemyBoard
                        width: 300
                        height: 300
                        anchors.top: parent.top
                        anchors.topMargin: Math.max(window.width, window.height)/30
                        anchors.right: parent.right
                        anchors.rightMargin: Math.max(window.width, window.height)/10
                        delegate: Item {
                            x: 5
                            height: 50
                            Column {
                                Rectangle {
                                    width: 40
                                    height: 40
                                    color: colorCode
                                    anchors.horizontalCenter: parent.horizontalCenter
                                }

                                Text {
                                    x: 5
                                    text: name
                                    anchors.horizontalCenter: parent.horizontalCenter
                                    font.bold: true
                                }
                                spacing: 5
                            }
                        }
                        cellHeight: 70
                        cellWidth: 70
                    }

                    GridView {
                        id: playerBoard
                        width: 300
                        height: 300
                        anchors.left: parent.left
                        anchors.leftMargin: Math.max(window.width, window.height)/10
                        anchors.top: parent.top
                        anchors.topMargin: Math.max(window.width, window.height)/30
                        delegate: Item {
                            x: 5
                            height: 50
                            Column {
                                Rectangle {
                                    width: 40
                                    height: 40
                                    color: colorCode
                                    anchors.horizontalCenter: parent.horizontalCenter
                                }

                                Text {
                                    x: 5
                                    text: name
                                    anchors.horizontalCenter: parent.horizontalCenter
                                    font.bold: true
                                }
                                spacing: 5
                            }
                        }
                        cellHeight: 70
                        cellWidth: 70
                    }
                }

            }
        }
    }

    ToolBar {
        id: toolBar
        x: 0
        y: 0
        width: window.width
        height: 26

        ToolButton {
            id: newGameToolButton
            width: 68
            height: 26
            text: qsTr("New game")
            enabled: true
            onClicked: {
                gamePage.visible = true
                shipsButton.enabled = true
                playButton.enabled = false
                exitButton.enabled = false
            }
        }

        ToolButton {
            id: shipsButton
            x: 74
            y: 0
            width: 40
            height: 26
            text: "Ships"
            enabled: false
            onClicked: menu.open()

            Menu {
                id: menu
                y: shipsButton.height

                MenuItem {
                    text: "1x Carrier (5 squares)"
                    height: shipsButton.height
                    enabled: false
                    background: Rectangle {
                        color: "#33333d"
                    }
                }
                MenuItem {
                    text: "2x Battleship (4 squares)"
                    height: shipsButton.height
                    enabled: false
                    background: Rectangle {
                        color: "#33333d"
                    }
                }
                MenuItem {
                    text: "3x Destroyer (3 squares)"
                    height: shipsButton.height
                    enabled: false
                    background: Rectangle {
                        color: "#33333d"
                    }
                }
                MenuItem {
                    text: "4x Corvette (2 squares)"
                    height: shipsButton.height
                    enabled: false
                    background: Rectangle {
                        color: "#33333d"
                    }
                }
            }
        }
    }
}

/*##^##
Designer {
    D{i:5;anchors_height:400;anchors_width:200;anchors_x:421;anchors_y:50}D{i:3;anchors_height:200;anchors_width:200}
D{i:24;anchors_x:0;anchors_y:0}D{i:20;anchors_x:0;anchors_y:0}D{i:11;anchors_height:400;anchors_width:200}
D{i:2;anchors_height:200;anchors_width:200}D{i:1;anchors_height:400;anchors_width:200;anchors_x:15;anchors_y:7}
D{i:25;anchors_x:0;anchors_y:0}
}
##^##*/
