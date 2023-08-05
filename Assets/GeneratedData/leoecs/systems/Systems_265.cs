using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System265 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component84,Component329,Component421,Component484> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component283>())
   {
    q+=1;
    var com = entity.Get<Component283>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component326>())
   {
    q+=1;
    var com = entity.Get<Component326>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component202>())
   {
    q+=1;
    var com = entity.Get<Component202>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component485>())
   {
    q+=1;
    var com = entity.Get<Component485>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
