using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System65 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component252,Component168,Component382,Component12> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component407>())
   {
    q+=1;
    var com = entity.Get<Component407>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component199>())
   {
    q+=1;
    var com = entity.Get<Component199>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component15>())
   {
    q+=1;
    var com = entity.Get<Component15>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component29>())
   {
    q+=1;
    var com = entity.Get<Component29>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
