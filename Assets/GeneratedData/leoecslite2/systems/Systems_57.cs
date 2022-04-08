using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System57 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component455>().Inc<Component243>().Inc<Component14>().Inc<Component370>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component284>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component284>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component491>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component491>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component177>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component177>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component142>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component142>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
