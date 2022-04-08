using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System4 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component48>().Inc<Component485>().Inc<Component92>().Inc<Component283>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component218>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component218>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component27>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component27>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component157>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component157>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component166>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component166>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
