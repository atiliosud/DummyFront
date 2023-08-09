import { useEffect, useState } from 'react';
import api from './api';
import  './app.css';
import UserList from './component/UserList';

function App() {

  const [users, setUsers] = useState([])

  const getUsers = async  () => await api.getUsers({limit: 10})

  useEffect(() => {
    (async () => {
      let {data} = await getUsers()
      setUsers(data)
    })()
  }, [])
  return (
    <div className="App">
      <main className='App-main'>
        <h1>User List</h1>
          <UserList data={users}/>
      </main>
    </div>
  );
}

export default App;
