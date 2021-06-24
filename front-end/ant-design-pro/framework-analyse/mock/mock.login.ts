import {Request, Response} from 'express';
import { waitTime } from './common';
import { LoginParamsType } from '@/modeltypes/Login'

let userList:LoginParamsType[] = [
  {
    userName: 'admin',
    password: 'admin', 
  },
  {
    userName: 'lucas',
    password: 'lucas',
  }
]
export default {
  'POST /api/login/account': async (req: Request, res: Response) => {
    const { password, userName, type } = req.body;
    await waitTime(3000);
    userList.forEach(item => {
      if (item.userName === userName && item.password === password)
      {
        res.send({
          status: 'ok',
          type,
          currentAuthority: item.userName === 'admin' ? 'admin' : 'user',
        });
      }
    })

    res.send({
      status: 'error',
      type,
      currentAuthority: 'guest',
    });
  },
}
