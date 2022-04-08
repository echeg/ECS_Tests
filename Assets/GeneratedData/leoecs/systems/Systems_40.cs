using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System40 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component2,Component218> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component169>())
   {
    q+=1;
    var com = entity.Get<Component169>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component155>())
   {
    q+=1;
    var com = entity.Get<Component155>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component275>())
   {
    q+=1;
    var com = entity.Get<Component275>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component475>())
   {
    q+=1;
    var com = entity.Get<Component475>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
