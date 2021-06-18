export type LoginParamsType = {
  userName: string;
  password: string;
  mobile: string;
  captcha: string;
};

export type LoginStateType = {
  status?: 'ok' | 'error';
  type?: string;
  currentAuthority?: 'user' | 'guest' | 'admin';
};

export interface ILoginOperation {
  SuccessLogin: Function;
}

// export class Login implements ILoginOperation {

// }
