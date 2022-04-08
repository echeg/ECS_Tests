using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System64 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component177,Component360> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component10>())
   {
    q+=1;
    var com = entity.Get<Component10>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component137>())
   {
    q+=1;
    var com = entity.Get<Component137>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component429>())
   {
    q+=1;
    var com = entity.Get<Component429>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component18>())
   {
    q+=1;
    var com = entity.Get<Component18>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
