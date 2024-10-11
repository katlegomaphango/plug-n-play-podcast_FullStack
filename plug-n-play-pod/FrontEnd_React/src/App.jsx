import { Route, Routes } from 'react-router-dom'
import './App.css'
import Navbar from './components/NavBar/Navbar'
import SignUp from './pages/AdminPage'
import Login from './pages/LoginPage'

function App() {
  return (
    <>
      <Navbar />

      <Routes>
        <Route path='/' element={<Login />} />
        <Route path='/signup' element={<SignUp />} />
      </Routes>
      
      
    </>
  )
}

export default App
