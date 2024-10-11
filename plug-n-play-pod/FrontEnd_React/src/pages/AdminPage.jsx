import { Box, Button, styled, Typography } from "@mui/material"
import { useState } from "react"
import { Link } from "react-router-dom"

const MainBox = styled(Box)({
    width: '100%',
    height: '100%',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    flexDirection: 'column',
    marginTop: '10rem',
    gap: 20
})

const StyledBox = styled(Box)({
    backgroundColor: "white",
    padding: '1rem',
    borderRadius: '0.5rem',
    boxShadow: '6px 19px 23px 1px rgba(0,0,0,0.15)',
})

const SubmitButton = styled(Button)({
    width: '50%',
    backgroundColor: 'rgb(180, 0, 218)',
    fontWeight: 'bold',
    fontSize: '1rem'
})

const SignUp = () => {
  const [formData, setFormData] = useState({
      firstName: '',
      lastName: '',
      email: '',
      phoneNumber: '',
      password: ''
  })
  const handleRegister = () => {
      // handle register
  }

  const handleFormInput = (e) => {
      setFormData((prev) => {
          return {
              ...prev,
              [e.target.name]: e.target.value
          }
      })
  }

  console.log(formData)
  return (
      <MainBox>
        <Typography  variant="h2" sx={{fontWeight: 'bold', color: 'white'}}>
            Register
        </Typography>
        <StyledBox>
            <form onSubmit={handleRegister}>
                <div style={{marginBottom: 20}}>
                    <input 
                        type="text"
                        placeholder="your first name"
                        name="firstName"
                        onChange={handleFormInput}
                        style={{
                            border: '1px solid',
                            borderRadius: '0.3rem',
                            padding: '0.5rem',
                            fontSize: '1.5rem'
                        }}
                    />
                </div>

                <div style={{marginBottom: 20}}>
                    <input 
                        type="text"
                        placeholder="your last name"
                        name="lastName"
                        onChange={handleFormInput}
                        style={{
                            border: '1px solid',
                            borderRadius: '0.3rem',
                            padding: '0.5rem',
                            fontSize: '1.5rem'
                        }}
                    />
                </div>

                <div style={{marginBottom: 20}}>
                    <input 
                        type="email"
                        placeholder="your email"
                        name="email"
                        onChange={handleFormInput}
                        style={{
                            border: '1px solid',
                            borderRadius: '0.3rem',
                            padding: '0.5rem',
                            fontSize: '1.5rem'
                        }}
                    />
                </div>

                <div style={{marginBottom: 20}}>
                    <input 
                        type="password"
                        placeholder="your password"
                        name="password"
                        onChange={handleFormInput}
                        style={{
                            border: '1px solid',
                            borderRadius: '0.3rem',
                            padding: '0.5rem',
                            fontSize: '1.5rem'
                        }}
                    />
                </div>

                <div style={{marginBottom: 20}}>
                    <input 
                        type="text"
                        placeholder="your phone number"
                        name="phoneNumber"
                        onChange={handleFormInput}
                        style={{
                            border: '1px solid',
                            borderRadius: '0.3rem',
                            padding: '0.5rem',
                            fontSize: '1.5rem'
                        }}
                    />
                </div>

                <div style={{display: 'flex', justifyContent: 'center'}}>
                    <SubmitButton type="submit" variant="contained">
                        Register
                    </SubmitButton>
                </div>
            </form>
        </StyledBox>
        <Typography variant="h6">
            Already have an account?
            <Link to={'/'} style={{color: 'white', textDecoration: 'none', marginLeft: '0.5rem'}}>
                Login
            </Link>
        </Typography>
      </MainBox>
  )
}

export default SignUp