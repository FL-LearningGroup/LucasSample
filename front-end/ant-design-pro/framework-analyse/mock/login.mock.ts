import {Request, Response} from 'express';
import { WaitTime } from './common';

export default {
  "POST /api/login/account": async (req: Request, res: Response) => {
    await WaitTime(3000);
    console.log("login");
  }
}
