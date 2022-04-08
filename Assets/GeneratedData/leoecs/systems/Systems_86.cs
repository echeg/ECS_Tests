using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System86 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component431,Component209,Component61,Component202> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component320>())
   {
    q+=1;
    var com = entity.Get<Component320>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component10>())
   {
    q+=1;
    var com = entity.Get<Component10>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component405>())
   {
    q+=1;
    var com = entity.Get<Component405>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
