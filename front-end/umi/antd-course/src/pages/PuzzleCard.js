import React, { Component } from 'react';
import { Card, Button } from 'antd';
import { connect } from 'dva';

const namespace = 'puzzlecards';

const mapStateToProps = (state) => ({
  cardList: state.puzzlecards
});


const PuzzleCard = (props) => {
  const { cardList } = props
  // addNewCard = () => {
  //   this.setState(prevState => {
  //     const prevCardList = prevState.cardList;
  //     this.counter += 1;
  //     const card = {
  //       id: this.counter,
  //       setup: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit,',
  //       punchline: 'sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
  //     };
  //     return {
  //       cardList: prevCardList.concat(card),
  //     };
  //   });
  // }
  return (
    <div>
      {
          cardList
          .map(card => {
          return (
            <Card key={card.id}>
              <div>Q: {card.setup}</div>
              <div>
                <strong>A: {card.punchline}</strong>
              </div>
            </Card>
          );
        })
      }
    </div>
  )
}
export default connect(mapStateToProps)(PuzzleCard);