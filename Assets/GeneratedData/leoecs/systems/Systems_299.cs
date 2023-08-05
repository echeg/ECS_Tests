using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System299 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component134> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component133>())
   {
    q+=1;
    var com = entity.Get<Component133>();
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
   if (entity.Has<Component443>())
   {
    q+=1;
    var com = entity.Get<Component443>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component453>())
   {
    q+=1;
    var com = entity.Get<Component453>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
