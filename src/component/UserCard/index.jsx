import React from 'react';
import  './style.css';


// USER DATA {
//     "id": "60d0fe4f5311236168a109ca",
//     "title": "ms",
//     "firstName": "Sara",
//     "lastName": "Andersen",
//     "picture": "https://randomuser.me/api/portraits/women/58.jpg"
// }
export default ({user = {}}) => {
    return (
        <div className='user-card-container'>
            <div className='user-card-img-container'>
                <img src={user.owner.picture} className='user-card-img'/>
            </div>
            <div className='user-card-content-container'>
                <span className='user-card-content-id'>{user.id}</span>
                <span className='user-card-content-full-name'>{`${user.owner.firstName} ${user.owner.lastName}`}</span>
            </div>
        </div>
    )
}