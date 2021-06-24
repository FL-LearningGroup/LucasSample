export type LoginParamsType = {
  userName: string;
  password: string;
};

export type LoginStateType = {
  status?: 'ok' | 'error';
  type?: string;
  currentAuthority?: 'user' | 'guest' | 'admin';
};