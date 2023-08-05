using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System284 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component362> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component84>())
   {
    q+=1;
    var com = entity.Get<Component84>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component300>())
   {
    q+=1;
    var com = entity.Get<Component300>();
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
   if (entity.Has<Component151>())
   {
    q+=1;
    var com = entity.Get<Component151>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
