import { v4 as uuidv4 } from 'uuid';
import request from '../utils/request';

export default {
  namespace: 'puzzlecards',
  state: [],
  effects: {
    *initCard(_, {call, put}) {
      console.log('effect');

      const endPointURI = '/api/InitCard?code=x48OUZpJultzsBhj20via1ah8CajRatArycjMTyokuyARaT4sGZjjw=='
      
      const puzzle = yield call(request,endPointURI);
      console.log(puzzle);
      yield put({type: 'initDefaultCard', payload:puzzle});
    }
  },
  reducers: {
    initDefaultCard(state, {payload: card}) {
      return state.concat(card);
    },
    addCard(state) {
      const card = {
        id: uuidv4(),
        setup: 'Lorem ipsum dolor sit amet, consectetur adipiscing elit,',
        punchline: 'sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.',
      };
      console.log(card)
      return state.concat(card)
    },
    removeCard(state, {payload: id}) {
      return state.filter(item => item.id != id);
    },
  }
};