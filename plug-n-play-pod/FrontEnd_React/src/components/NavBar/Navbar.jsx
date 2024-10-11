import { AppBar, Avatar, Button, styled, Toolbar, Typography } from '@mui/material'
import { Login, Logout } from '@mui/icons-material'

const AppToolbar = styled(Toolbar)({
  backgroundColor: 'rgb(180, 0, 218)',
  display: 'flex',
  justifyContent: 'space-between'
})

const LogoText = styled(Typography)({
  fontSize: '1.5rem',
  fontWeight: 'bold',
  marginLeft: '0.5rem',
})

const LoginButton = styled(Button)({
  border: '2px solid',
  color: 'white'
})

const Navbar = () => {
  return (
    <AppBar position='sticky'>
        <AppToolbar>
          <Toolbar>
            <Avatar alt='logo' src='' />  {/* need input the logo */}
            <LogoText variant='h1' sx={{display: {xs: 'none', sm: 'block'}}}>
              Plug &lsquo;n Play
            </LogoText>
          </Toolbar>

          <LoginButton variant='outlined'>
            <Login />
            <Typography ml={1} sx={{display: {xs: 'none', sm: 'block'}}}>
              Login
            </Typography>
          </LoginButton>

          {/* <LoginButton variant='outlined'>
            <Logout />
            <Typography ml={1} sx={{display: {xs: 'none', sm: 'block'}}}>
              Logout
            </Typography>
          </LoginButton> */}
        </AppToolbar>
    </AppBar>
  )
}

export default Navbar