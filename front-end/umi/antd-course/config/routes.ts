export default [
  { 
    path: '/',
    component: '@/layout/BasicLayout',
    routes: [
      {
        path: '/card',
        component: './SampleCard'
      },
      {
        path: '/dashboard',
        routes: [
          { path: '/dashboard/analysis', component: './Dashboard/Analysis' },
          { path: '/dashboard/monitor', component: './Dashboard/Monitor' },
          { path: '/dashboard/workplace', component: './Dashboard/Workplace' }
        ]
      },
      { path: '/puzzlecards', component: './PuzzleCard' },
    ]
  }
];