import React, { Component } from 'react';
import { Card, Button } from 'antd';
import { connect } from 'dva';
import { EditOutlined, DeleteOutlined } from '@ant-design/icons';

const namespace = 'puzzlecards';

const mapStateToProps = (state) => ({
  cardList: state.puzzlecards
});

const mapDispatchToProps = {
  initCard:() => ({type: "puzzlecards/initCard"}),
  addCard:() => ({type: "puzzlecards/addCard"}),
  removeCard:(id) => ({type: "puzzlecards/removeCard", payload: id}),
  updateCard:(payload) => ({type: "puzzlecards/updateCard"})
}

class PuzzleCard extends Component {

  componentDidMount() {
    console.log("Trigger init card method.");
    this.props.initCard();
  }
  render() {
    return (
      <div>
        {
            this.props.cardList.map(card => {
            return (
              <Card key={card.id}     
              actions={[
                <EditOutlined onClick={() => this.props.updateCard()} key="edit" />,
                <DeleteOutlined onClick={() =>{this.props.removeCard(card.id)}} key="delete"/>,
              ]}
              hoverable={true}
              style={{marginBottom: '10px'}}
              >
                <div>Q: {card.setup}</div>
                <div>
                  <strong>A: {card.punchline}</strong>
                </div>
              </Card>
            );
          })
        }
        <Button onClick={() => this.props.addCard() } size='large'>Add Card</Button>
      </div>
    )
  }
}
export default connect(mapStateToProps,mapDispatchToProps)(PuzzleCard);