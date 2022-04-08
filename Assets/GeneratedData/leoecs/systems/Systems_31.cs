using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System31 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component104>())
   {
    q+=1;
    var com = entity.Get<Component104>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component189>())
   {
    q+=1;
    var com = entity.Get<Component189>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component317>())
   {
    q+=1;
    var com = entity.Get<Component317>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component480>())
   {
    q+=1;
    var com = entity.Get<Component480>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
