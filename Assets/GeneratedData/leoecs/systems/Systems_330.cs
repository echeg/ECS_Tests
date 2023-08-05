using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System330 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component355,Component172,Component33,Component270> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component305>())
   {
    q+=1;
    var com = entity.Get<Component305>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component76>())
   {
    q+=1;
    var com = entity.Get<Component76>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component470>())
   {
    q+=1;
    var com = entity.Get<Component470>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component272>())
   {
    q+=1;
    var com = entity.Get<Component272>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
