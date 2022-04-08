using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System96 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component117,Component390> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component492>())
   {
    q+=1;
    var com = entity.Get<Component492>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component197>())
   {
    q+=1;
    var com = entity.Get<Component197>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component436>())
   {
    q+=1;
    var com = entity.Get<Component436>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component394>())
   {
    q+=1;
    var com = entity.Get<Component394>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
